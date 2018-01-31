import * as React from 'react';
import { Link, NavLink } from 'react-router-dom';

export class NavMenu extends React.Component<{}, {}> {
    public render() {
        return <div>
                    <Link to={'/'}>SpaUi</Link>
                    <nav>
                        <ul>
                            <li>
                                <NavLink to={ '/' } exact activeClassName='active'>
                                       Home
                                   </NavLink>
                            </li>
                            <li>
                                <NavLink to={ '/counter' } exact activeClassName='active'>
                                       Counter
                                   </NavLink>
                            </li>
                            <li>
                                <NavLink to={ '/fetchdata' } exact activeClassName='active'>
                                       Fetch data
                                   </NavLink>
                            </li>
                        </ul>
                    </nav>
                </div>;
    }
}