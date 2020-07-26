import React, { Component } from "react";
import { Nav, Navbar } from "react-bootstrap";
import whiteCart from "../../Images/cartWhite.png";
import pinkCart from "../../Images/cartPink.png";
import greenCart from "../../Images/cartGreen.png";
import "./Navbar.css";
import { scroller } from "react-scroll";

class MNavbar extends Component {
  constructor(props) {
    super(props);
    this.state = {
      cartHovered: false,
    };
  }

  onMouseEnterHandler() {
    this.setState({
      cartHovered: true,
    });
  }

  onMouseLeaveHandler() {
    this.setState({
      cartHovered: false,
    });
  }

  scrollToPlants() {
    scroller.scrollTo("plants", {
      smooth: true,
      duration: 500,
      spy: true,
    });
  }
  scrollToContact() {
    scroller.scrollTo("contact", {
      smooth: true,
      duration: 500,
      spy: true,
    });
  }
  scrollToHome() {
    scroller.scrollTo("home", {
      smooth: true,
      duration: 500,
      spy: true,
    });
  }

  scrollToCart() {
    scroller.scrollTo("cart", {
      smooth: true,
      duration: 500,
      spy: true,
    });
  }

  render() {
    return (
      <Navbar bg="dark" expand="lg" fixed="top" variant="dark">
        <Navbar.Brand
          className="nav-brand"
          href="#"
          onClick={this.scrollToHome}
        >
          Planty
        </Navbar.Brand>
        <Navbar.Toggle aria-controls="basic-navbar-nav" />
        <Navbar.Collapse id="basic-navbar-nav">
          <Nav className="ml-auto">
            <Nav.Link href="#home" onClick={this.scrollToHome}>
              Home
            </Nav.Link>
            <Nav.Link href="#plants" onClick={this.scrollToPlants}>
              Plants
            </Nav.Link>
            <Nav.Link href="#contact" onClick={this.scrollToContact}>
              Contact
            </Nav.Link>
            <Nav.Link
              onMouseEnter={this.onMouseEnterHandler.bind(this)}
              onMouseLeave={this.onMouseLeaveHandler.bind(this)}
              href="#cart"
              onClick={this.scrollToCart}
            >
              <img
                className="cart"
                src={
                  this.state.cartHovered
                    ? pinkCart
                    : this.props.isCartEmpty
                    ? whiteCart
                    : greenCart
                }
                alt="shoping cart"
              ></img>
            </Nav.Link>
          </Nav>
        </Navbar.Collapse>
      </Navbar>
    );
  }
}

export default MNavbar;
