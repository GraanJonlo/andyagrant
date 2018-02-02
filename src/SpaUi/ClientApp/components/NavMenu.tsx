import * as React from 'react';
import { Link, NavLink } from 'react-router-dom';

export class NavMenu extends React.Component<{}, {}> {
    public render() {
        return <div>
                    <nav className='navbar'>
                        <div className='nabar-menu'>
                            <div className="navbar-start">
                                <NavLink to={ '/' } exact className='navbar-item'>
                                    Home
                                </NavLink>
                                <NavLink to={ '/counter' } exact className='navbar-item'>
                                    Counter
                                </NavLink>
                                <NavLink to={ '/fetchdata' } exact className='navbar-item'>
                                    Fetch data
                                </NavLink>
                            </div>
                        </div>
                    </nav>
                </div>;
    }
}