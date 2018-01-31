import * as React from 'react';
import { RouteComponentProps } from 'react-router';

export class Home extends React.Component<RouteComponentProps<{}>, {}> {
    public render() {
        return <div className='columns'>
                    <div className='column'>
                        <div className='card'>
                            <div className='card-content'>
                                1
                            </div>
                        </div>
                    </div>
                    <div className='column'>
                        <div className='card'>
                            <div className='card-content'>
                                2
                            </div>
                        </div>
                    </div>
                    <div className='column'></div>
               </div>;
    }
}