import React, { Component } from 'react';

interface CounterState {
  currentCount: number
}


export class Counter extends Component<{}, CounterState> {
  static displayName = Counter.name;

  constructor (props: any) {
    super(props);
    this.state = { currentCount: 0 };
  }

  incrementCounter = () => {
    return this.setState({
      currentCount: this.state.currentCount + 1
    });
  }

  render () {
    return (
      <div>
        <h1>Counter</h1>

        <p>This is a simple example of a React component.</p>

        <p>Current count: <strong>{this.state.currentCount}</strong></p>

        <button className="btn btn-primary" onClick={this.incrementCounter}>Increment</button>
      </div>
    );
  }
}
