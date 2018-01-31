const path = require('path');
const webpack = require('webpack');
const ExtractTextPlugin = require('extract-text-webpack-plugin');

module.exports = (env) => {
    const extractCSS = new ExtractTextPlugin('vendor.css');
    const isDevBuild = !(env && env.prod);
    return [
        {
            stats: { modules: false },
            resolve: {
                extensions: ['.js']
            },
            module: {
                rules: [
                    { test: /\.(png|woff|woff2|eot|ttf|svg)(\?|$)/, use: 'url-loader?limit=100000' },
                    {
                        test: /\.css(\?|$)/,
                        use: extractCSS.extract([isDevBuild ? 'css-loader' : 'css-loader?minimize'])
                    },
                    {
                        test: /\.(sass|scss)$/,
                        use: extractCSS.extract({
                            use: [{
                                loader: "css-loader"
                            }, {
                                loader: "sass-loader"
                            }],
                            // use style-loader in development
                            fallback: "style-loader"
                        })
                    }
                ]
            },
            entry: {
                vendor: [
                    'bulma', 'event-source-polyfill', 'isomorphic-fetch',
                    'react', 'react-dom', 'react-router-dom'
                ],
            },
            output: {
                path: path.join(__dirname, 'wwwroot', 'dist'),
                publicPath: 'dist/',
                filename: '[name].js',
                library: '[name]_[hash]',
            },
            plugins: [
                extractCSS,
                new webpack.DllPlugin({
                    path: path.join(__dirname, 'wwwroot', 'dist', '[name]-manifest.json'),
                    name: '[name]_[hash]'
                }),
                new webpack.DefinePlugin({
                    'process.env.NODE_ENV': isDevBuild ? '"development"' : '"production"'
                })
            ].concat(isDevBuild
                ? []
                : [
                    new webpack.optimize.UglifyJsPlugin()
                ])
        }
    ];
};