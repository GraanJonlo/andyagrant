import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { Link } from 'react-router-dom';

export class Home extends React.Component<RouteComponentProps<{}>, {}> {
    public render() {
        return <div className='container'>
                    <div className='columns'>
                        <div className='column is-two-thirds'>
                            <div className='card'>
                                <Link to={'/videopost/1234'}>
                                    <div className="card-image">
                                        <figure className="image is-4by3">
                                            <img src="https://bulma.io/images/placeholders/1280x960.png" alt="Placeholder image" />
                                        </figure>
                                    </div>
                                </Link>
                                <div className='card-content'>
                                    <h2 className='title'>XPMan 61.5 - Abstractions</h2>
                                    <p>Matt Cannon at the Extreme Programming Manchester 2015 Lightning Talks.</p>
                                    <p><time dateTime="2018-02-02">2/2/2018</time></p>
                                </div>
                            </div>
                        </div>
                        <div className='column'>
                            <div className='card'>
                                <Link to={'/videopost/1234'}>
                                    <div className="card-image">
                                        <figure className="image is-4by3">
                                            <img src="https://bulma.io/images/placeholders/1280x960.png" alt="Placeholder image" />
                                        </figure>
                                    </div>
                                </Link>
                                <div className='card-content'>
                                    <h2 className='title'>XPMan 61.4 - Collaboration</h2>
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
                                        <figure className="image is-4by3">
                                            <img src="https://bulma.io/images/placeholders/1280x960.png" alt="Placeholder image" />
                                        </figure>
                                    </div>
                                </Link>
                                <div className='card-content'>
                                    <h2 className='title'>XPMan 61.3 - Hidden Queues</h2>
                                    <p>James Jeffries at the Extreme Programming Manchester 2015 Lightning Talks.</p>
                                    <p><time dateTime="2018-02-02">2/2/2018</time></p>
                                </div>
                            </div>
                        </div>
                        <div className='column'>
                            <div className='card'>
                                <Link to={'/videopost/1234'}>
                                    <div className="card-image">
                                        <figure className="image is-4by3">
                                            <img src="https://bulma.io/images/placeholders/1280x960.png" alt="Placeholder image" />
                                        </figure>
                                    </div>
                                </Link>
                                <div className='card-content'>
                                    <h2 className='title'>XPMan 61.2 - Microservices</h2>
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
                                        <img src="/images/xpman611.jpg" alt="Placeholder image" />
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
                </div>
            </div>;
    }
}