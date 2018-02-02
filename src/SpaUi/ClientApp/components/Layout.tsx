import * as React from 'react';
import { NavMenu } from './NavMenu';
import { Link, NavLink } from 'react-router-dom';

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
                            <h1 className='title'><Link to={'/'}>Title</Link></h1>
                            <h2 className='subtitle'>Subtitle</h2>
                            <NavMenu />
                        </header>
                    </div>
                </div>
            </section>
            <section className='section'>
                <div className='container'>
                    { this.props.children }
                </div>
            </section>
            <footer className="footer">
                <div className="container">
                    <div className="content has-text-centered">
                    <p>
                        It's a footer!
                    </p>
                    </div>
                </div>
                </footer>
        </div>;
    }
}