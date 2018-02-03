import * as React from 'react';
import { RouteComponentProps } from 'react-router';

export class Home extends React.Component<RouteComponentProps<{}>, {}> {
    public render() {
        return <div className='columns'>
                    <div className='column'>
                        <div className='card'>
                            <div className="card-image">
                                <figure className="image is-4by3">
                                    <img src="https://bulma.io/images/placeholders/1280x960.png" alt="Placeholder image" />
                                </figure>
                            </div>
                            <div className='card-content'>
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur at lacinia neque, sit amet rhoncus orci. Integer aliquet sapien venenatis libero cursus, vel sollicitudin arcu eleifend.</p>
                                <p><time dateTime="2018-02-02">2/2/2018</time></p>
                            </div>
                        </div>
                    </div>
                    <div className='column'>
                        <div className="card">
                            <div className="card-content">
                                <p className="title">
                                “There are two hard things in computer science: cache invalidation, naming things, and off-by-one errors.”
                                </p>
                                <p className="subtitle">
                                Jeff Atwood
                                </p>
                            </div>
                            <footer className="card-footer">
                                <p className="card-footer-item">
                                <span>
                                    View on <a href="https://twitter.com/codinghorror/status/506010907021828096">Twitter</a>
                                </span>
                                </p>
                                <p className="card-footer-item">
                                <span>
                                    Share on <a href="#">Facebook</a>
                                </span>
                                </p>
                            </footer>
                        </div>
                    </div>
               </div>;
    }
}