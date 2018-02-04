import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { Link } from 'react-router-dom';

import { VideoCard } from './VideoCard';

export class Home extends React.Component<RouteComponentProps<{}>, {}> {
    public render() {
        return <div className='container'>
                    <div className='columns'>
                        <div className='column is-half'>
                            <VideoCard
                                id='xpman62'
                                title='XPMan 62 - In Defence of Mocks, with Mark Kirschstein'
                                summary='<p>Are mocks pointless? This session argues maybe, maybe not…</p>'
                                placeholder='/images/xpman62.svg'
                                image='/images/xpman62.jpg'
                                timestamp='2018-02-04' />
                        </div>
                        <div className='column'>
                            <VideoCard
                                id='xpman616'
                                title='XPMan 61.6 - Bug Free Code'
                                summary='<p>Gemma Cameron at the Extreme Programming Manchester 2015 Lightning Talks.</p>'
                                placeholder='/images/xpman616.svg'
                                image='/images/xpman616.jpg'
                                timestamp='2018-02-04' />
                        </div>
                        <div className='column'>
                            <VideoCard
                                id='xpman615'
                                title='XPMan 61.5 - Abstractions'
                                summary='<p>Matt Cannon at the Extreme Programming Manchester 2015 Lightning Talks.</p>'
                                placeholder='/images/xpman615.svg'
                                image='/images/xpman615.jpg'
                                timestamp='2018-02-04' />
                        </div>
                    </div>
                    <div className='columns'>
                        <div className='column'>
                            <VideoCard
                                id='xpman614'
                                title='XPMan 61.4 - Collaboration'
                                summary='<p>Clare Sudbery at the Extreme Programming Manchester 2015 Lightning Talks.</p>'
                                placeholder='/images/xpman614.svg'
                                image='/images/xpman614.jpg'
                                timestamp='2018-02-04' />
                        </div>
                        <div className='column'>
                            <VideoCard
                                id='xpman613'
                                title='XPMan 61.3 - Hidden Queues'
                                summary='<p>James Jeffries at the Extreme Programming Manchester 2015 Lightning Talks.</p>'
                                placeholder='/images/xpman613.svg'
                                image='/images/xpman613.jpg'
                                timestamp='2018-02-04' />
                        </div>
                        <div className='column'>
                            <VideoCard
                                id='xpman612'
                                title='XPMan 61.2 - Microservices'
                                summary='<p>Nima Montazeri at the Extreme Programming Manchester 2015 Lightning Talks.</p>'
                                placeholder='/images/xpman612.svg'
                                image='/images/xpman612.jpg'
                                timestamp='2018-02-04' />
                        </div>
                        <div className='column'>
                            <VideoCard
                                id='xpman611'
                                title='XPMan 61.1 - We Said It Would Be Simple, Not Easy'
                                summary='<p>Andy Longshaw at the Extreme Programming Manchester 2015 Lightning Talks.</p>'
                                placeholder='/images/xpman611.svg'
                                image='/images/xpman611.jpg'
                                timestamp='2018-02-04' />
                        </div>
                    </div>
                </div>;
    }
}