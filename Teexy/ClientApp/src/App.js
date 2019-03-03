import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';

import Allchallenges from './components/base/allchallenges'
import MyChallenges from './components/base/mychallenges'
import LoginSocial from './components/login'
import Profile from './components/base/profile'

import "./App.sass"

export default class App extends Component {
  static displayName = App.name;

  render () {

    return (
      <Layout>
        <Route exact path='/' component={Allchallenges} />
        <Route path='/login' component={LoginSocial} />
        <Route path='/challenges/my' component={MyChallenges} />
        <Route path='/profile/my' component={Profile} />
      </Layout>
    );
  }
}
