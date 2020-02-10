import React, { Component } from 'react';
import { Container, Content, Form, Item, Input, Label, Button, Text } from 'native-base';

export class InsertDay extends Component {
  render() {
    return (
          <Form>
            <Item stackedLabel>
              <Label>Entregas</Label>
              <Input keyboardType={"numeric"} />
            </Item>
            <Item stackedLabel>
              <Label>Ganhos Total</Label>
              <Input keyboardType={"numeric"} />
            </Item>
            <Item stackedLabel>
              <Label>Ganhos Hora Garantida</Label>
              <Input keyboardType={"numeric"}/>
            </Item>
            <Item stackedLabel last>
              <Label>Retirada Diaria</Label>
              <Input keyboardType={"numeric"}/>
            </Item>
            <Button primary><Text> Primary </Text></Button>
          </Form>
    );
  }
}