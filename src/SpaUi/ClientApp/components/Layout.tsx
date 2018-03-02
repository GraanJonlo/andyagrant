import * as React from 'react';
import { NavMenu } from './NavMenu';
import { Link } from 'react-router-dom';

export interface LayoutProps {
    children?: React.ReactNode;
}

export class Layout extends React.Component<LayoutProps, {}> {
    public render() {
        return <div>
            <section className='hero is-primary'>
                <div className='hero-body'>
                    <div className='container'>
                        <header>
                            <h1 className='title'><Link to={'/'}>Andy Grant</Link></h1>
                            <h2 className='subtitle'>Programming and gaming in Manchester UK</h2>
                            <NavMenu />
                        </header>
                    </div>
                </div>
            </section>
            <section className='section'>
                { this.props.children }
            </section>
            <footer className="footer">
                <div className="container">
                    <div className="content has-text-centered">
                    <p>
                        It's a footer! 2018-03-02T16:13
                    </p>
                    </div>
                </div>
                </footer>
        </div>;
    }
}