import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { Link } from 'react-router-dom';

export class Home extends React.Component<RouteComponentProps<{}>, {}> {
    public render() {
        return <div className='container'>
                    <div className='columns'>
                        <div className='column is-half'>
                            <div className='card'>
                                <Link to={'/videopost/1234'}>
                                    <div className="card-image">
                                        <figure className="image is-16by9">
                                        <img src="/images/xpman616.svg" className='imgPlaceholder' data-large='/images/xpman616.jpg' alt='Placeholder image' />
                                        </figure>
                                    </div>
                                </Link>
                                <div className='card-content'>
                                    <h2 className='title is-4'>XPMan 61.6 - Bug Free Code</h2>
                                    <p>Gemma Cameron at the Extreme Programming Manchester 2015 Lightning Talks.</p>
                                    <p><time dateTime="2018-02-02">2/2/2018</time></p>
                                </div>
                            </div>
                        </div>
                        <div className='column'>
                            <div className='card'>
                                <Link to={'/videopost/1234'}>
                                    <div className="card-image">
                                        <figure className="image is-16by9">
                                        <img src="/images/xpman615.svg" className='imgPlaceholder' data-large='/images/xpman615.jpg' alt='Placeholder image' />
                                        </figure>
                                    </div>
                                </Link>
                                <div className='card-content'>
                                    <h2 className='title is-4'>XPMan 61.5 - Abstractions</h2>
                                    <p>Matt Cannon at the Extreme Programming Manchester 2015 Lightning Talks.</p>
                                    <p><time dateTime="2018-02-02">2/2/2018</time></p>
                                </div>
                            </div>
                        </div>
                        <div className='column'>
                            <div className='card'>
                                <Link to={'/videopost/1234'}>
                                    <div className="card-image">
                                        <figure className="image is-16by9">
                                            <img src="/images/xpman614.svg" className='imgPlaceholder' data-large='/images/xpman614.jpg' alt='Placeholder image' />
                                        </figure>
                                    </div>
                                </Link>
                                <div className='card-content'>
                                    <h2 className='title is-4'>XPMan 61.4 - Collaboration</h2>
                                    <p>Clare Sudbery at the Extreme Programming Manchester 2015 Lightning Talks.</p>
                                    <p><time dateTime="2018-02-02">2/2/2018</time></p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div className='columns'>
                        <div className='column'>
                            <div className='card'>
                                <Link to={'/videopost/1234'}>
                                    <div className="card-image">
                                        <figure className="image is-16by9">
                                            <img src="/images/xpman613.svg" className='imgPlaceholder' data-large='/images/xpman613.jpg' alt='Placeholder image' />
                                        </figure>
                                    </div>
                                </Link>
                                <div className='card-content'>
                                    <h2 className='title is-4'>XPMan 61.3 - Hidden Queues</h2>
                                    <p>James Jeffries at the Extreme Programming Manchester 2015 Lightning Talks.</p>
                                    <p><time dateTime="2018-02-02">2/2/2018</time></p>
                                </div>
                            </div>
                        </div>
                        <div className='column'>
                            <div className='card'>
                                <Link to={'/videopost/1234'}>
                                    <div className="card-image">
                                        <figure className="image is-16by9">
                                            <img src="/images/xpman612.svg" className='imgPlaceholder' data-large='/images/xpman612.jpg' alt='Placeholder image' />
                                        </figure>
                                    </div>
                                </Link>
                                <div className='card-content'>
                                    <h2 className='title is-4'>XPMan 61.2 - Microservices</h2>
                                    <p>Nima Montazeri at the Extreme Programming Manchester 2015 Lightning Talks.</p>
                                    <p><time dateTime="2018-02-02">2/2/2018</time></p>
                                </div>
                            </div>
                        </div>
                        <div className='column'>
                            <div className='card'>
                                <Link to={'/videopost/1234'}>
                                    <div className="card-image">
                                        <figure className="image is-16by9">
                                            <img src="/images/xpman611.svg" className='imgPlaceholder' data-large='/images/xpman611.jpg' alt='Placeholder image' />
                                        </figure>
                                    </div>
                                </Link>
                                <div className='card-content'>
                                    <h2 className='title is-4'>XPMan 61.1 - We Said It Would Be Simple, Not Easy</h2>
                                    <p>Andy Longshaw at the Extreme Programming Manchester 2015 Lightning Talks.</p>
                                    <p><time dateTime="2018-02-02">2/2/2018</time></p>
                                </div>
                            </div>
                        </div>
                        <div className='column'></div>
                    </div>
                </div>;
    }
}