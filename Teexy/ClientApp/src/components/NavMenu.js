import React, { Component } from 'react';
import { Navbar, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.sass';


export class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor (props) {
    super(props);
    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true
    };
  }

  toggleNavbar () {
    this.setState({
      collapsed: !this.state.collapsed
    });
  }

  render () {
    return (
      <header>
        <Navbar className="nav">
          <h2 className="nav__title">Teexy</h2>
          <ul className="nav__list">
            <NavItem>
              <NavLink tag={Link} className="nav__item" to="/"><span className="text">All Challenges</span><span className="icon"><img src="/images/home.png" alt="home"/></span></NavLink>
            </NavItem>
            <NavItem>
              <NavLink tag={Link} className="nav__item" to="/challenges/my"><span className="text">My challenges</span><span className="icon"><img src="/images/challenge.svg" alt="challenge"/></span></NavLink>
            </NavItem>
            <NavItem>
              <NavLink tag={Link} className="nav__item" to="/profile/my"><span className="text">My profile</span><span className="icon"><img src="/images/user.svg" alt="user"/></span></NavLink>
            </NavItem>
          </ul>
        </Navbar>
      </header>
    );
  }
}
