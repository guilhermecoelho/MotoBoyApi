import React, { Component } from 'react';
import { Header, Left, Body, Right, Title } from 'native-base';

export class HeaderCustom extends Component {
  render() {
    return (
        <Header>
          <Left/>
          <Body>
            <Title>Header custon</Title>
          </Body>
          <Right />
        </Header>
    );
  }
}