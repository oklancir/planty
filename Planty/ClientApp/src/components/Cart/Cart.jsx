import React, { Component } from "react";
import { Container, Row, Col } from "react-bootstrap";
import "./Cart.css";
import { Plus, Dash, X, Check } from "react-bootstrap-icons";
import { Element } from "react-scroll";
import plants from "../../Images/Plants2.svg";

class Cart extends Component {
  constructor(props) {
    super(props);
    this.state = {
      plusHovered: false,
      minusHovered: false,
      xHovered: false,
    };
  }

  render() {
    let items = this.props.items.map((item, key) => (
      <Row className="list-item" key={item.name}>
        <Col xs="12" sm="4" md="3" lg={{ span: 2, offset: 1 }} className="img">
          {" "}
          <img className="img" src={item.src} alt="plant"></img>{" "}
        </Col>
        <Col className="details-row" xs="12" sm="4" md="5" lg="5">
          <span className="name">{item.name}</span>
          <div>{item.price}&euro;</div>
        </Col>
        <Col xs="12" sm="4" md="4" lg="3">
          <div className="quantity-plus-minus">
            <button className="btn-transparent">
              <Plus
                className="bi bi-plus"
                onClick={() =>
                  this.props.addToCart({
                    name: item.name,
                    src: item.src,
                    price: item.price,
                  })
                }
                width="1.5em"
                height="1.5em"
              ></Plus>
            </button>
            <span className="quantity">{item.quantity}</span>
            <button className="btn-transparent">
              {" "}
              <Dash
                onClick={() => this.props.removeFromCart(item.name, false)}
                width="1.5em"
                height="1.5em"
                className="bi bi-dash"
              ></Dash>
            </button>
          </div>

          <button
            onClick={() => this.props.removeFromCart(item.name, true)}
            className="remove"
          >
            {" "}
            <X width="1.5em" height="1.5em" className="bi bi-x"></X>
          </button>
        </Col>
      </Row>
    ));

    let total = 0;
    this.props.items.forEach((el) => {
      total += el.price * el.quantity;
    });

    const title = this.props.isCartEmpty ? "Your cart is empty." : "Your cart";
    const totals = this.props.isCartEmpty ? (
      <div className="img-container-cart">
        <img className="img-plants" src={plants} alt="plant ilustration"></img>
      </div>
    ) : (
      <Row className="totals-row">
        <Col>
          <div className="totals">
            <span className="total">Total: </span> {total.toFixed(2)}{" "}
            &euro;&nbsp;&nbsp;&nbsp;&nbsp; &bull; &nbsp;&nbsp;&nbsp;&nbsp;
            <span className="total">Proceed to payment</span>
            <button className="remove">
              {" "}
              <Check width="1.5em" height="1.5em" className="bi bi-x"></Check>
            </button>
          </div>
        </Col>
      </Row>
    );

    return (
      <Element name="cart">
        <div className="cart-container">
          <h1 className="title">{title}</h1>
          <Container className="cart-items">
            {items} {totals}
          </Container>
        </div>
      </Element>
    );
  }
}

export default Cart;
