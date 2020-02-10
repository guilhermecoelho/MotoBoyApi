import React, { Component } from 'react';
import { Container, Content, Form, Item, Input, Label, Button, Text } from 'native-base';

import {InsertDay} from './src/pages/insertDay';
import {HeaderCustom} from './src/pages/Header';

export default class StackedLabelExample extends Component {
  render() {
    return (
      <Container>
        <Content>
          <HeaderCustom></HeaderCustom>
          <InsertDay></InsertDay>
        </Content>
      </Container>
    );
  }
}