import * as React from 'react';
import { NavMenu } from './NavMenu';

export interface LayoutProps {
    children?: React.ReactNode;
}

export class Layout extends React.Component<LayoutProps, {}> {
    public render() {
        return <div>
            <section className='hero is-primary'>
                <div className='container'>
                    <header>
                        <h1 className='title'>Title</h1>
                        <h2 className='subtitle'>Subtitle</h2>
                        <NavMenu />
                    </header>
                </div>
            </section>
            <section>
                { this.props.children }
            </section>
        </div>;
    }
}