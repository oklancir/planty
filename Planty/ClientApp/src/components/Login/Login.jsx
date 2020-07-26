import React, { Component } from "react";
import "./Login.css";
import { Form, Button } from "react-bootstrap";

class Login extends Component {
  state = {
    username: "",
    pass: "",
    isSignUp: false,
  };
  render() {
    const signup = (
      <Form>
        <Form.Label className="login-form-title sign-up">Sign up</Form.Label>

        <Form.Group className="sign-up" controlId="formBasicEmail">
          <Form.Label>Email address</Form.Label>
          <Form.Control
            id="login-email"
            className="login sign-up"
            type="email"
            value={this.state.username}
            onChange={(event) =>
              this.setState({
                username: event.target.value,
              })
            }
            placeholder="Enter email"
          />
          <Form.Text>We'll never share your email with anyone else.</Form.Text>
        </Form.Group>

        <Form.Group className="sign-up" controlId="formBasicPassword">
          <Form.Label>Password</Form.Label>
          <Form.Control
            id="login-pass"
            className="login sign-up"
            value={this.state.pass}
            onChange={(event) =>
              this.setState({
                pass: event.target.value,
              })
            }
            type="password"
            placeholder="Password"
          />
        </Form.Group>
        <Form.Group className="sign-up" controlId="formBasicPassword">
          <Form.Label>Confirm password</Form.Label>
          <Form.Control
            id="login-pass"
            className="login sign-up"
            value={this.state.pass}
            onChange={(event) =>
              this.setState({
                pass: event.target.value,
              })
            }
            type="password"
            placeholder="Password"
          />
        </Form.Group>
        <Button
          id="signup-btn"
          onClick={() =>
            this.setState({
              isSignUp: false,
            })
          }
          variant="primary"
          type="submit"
        >
          Sign in
        </Button>
        <Button
          id="login-btn"
          onClick={() => this.setState({ isSignUp: false })}
          variant="primary"
          type="submit"
        >
          Sign up
        </Button>
      </Form>
    );

    const signin = (
      <Form>
        <Form.Group controlId="formBasicEmail">
          <Form.Label className="login-form-title">Sign in</Form.Label>
          <Form.Label>Email address</Form.Label>
          <Form.Control
            id="login-email"
            className="login"
            type="email"
            value={this.state.username}
            onChange={(event) =>
              this.setState({
                username: event.target.value,
              })
            }
            placeholder="Enter email"
          />
          <Form.Text>We'll never share your email with anyone else.</Form.Text>
        </Form.Group>

        <Form.Group controlId="formBasicPassword">
          <Form.Label>Password</Form.Label>
          <Form.Control
            id="login-pass"
            className="login"
            value={this.state.pass}
            onChange={(event) =>
              this.setState({
                pass: event.target.value,
              })
            }
            type="password"
            placeholder="Password"
          />
        </Form.Group>
        <Button
          id="signup-btn"
          onClick={() =>
            this.setState({
              isSignUp: true,
            })
          }
          variant="primary"
          type="submit"
        >
          Sign up
        </Button>
        <Button
          id="login-btn"
          onClick={() => this.props.login(this.state.username, this.state.pass)}
          variant="primary"
          type="submit"
        >
          Sign in
        </Button>
      </Form>
    );

    return (
      <div className="login-body">
        <div className="login-container">
          <div className="login-logo">
            <h1>Planty</h1>
          </div>
          <div className="login-form">
            {this.state.isSignUp ? signup : signin}
          </div>
        </div>
      </div>
    );
  }
}

export default Login;
