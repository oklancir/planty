import React, { Component } from "react";
import { Col } from "react-bootstrap";
import "./Plant.css";
import grayCart from "../../Images/cartGray.png";
import blueCart from "../../Images/cartBlue.png";

class Plant extends Component {
  constructor(props) {
    super(props);
    this.state = {
      hovered: false,
      cartHovered: false,
    };
  }

  onMouseEnterHandler() {
    this.setState({
      hovered: true,
    });
  }

  onMouseLeaveHandler() {
    this.setState({
      hovered: false,
    });
  }

  onMouseEnterCartHandler() {
    this.setState({
      cartHovered: true,
    });
  }

  onMouseLeaveCartHandler() {
    this.setState({
      cartHovered: false,
    });
  }

  render() {
    let imgClasses =
      "plant-" +
      (this.props.isVertical ? "vertical" : "horizontal") +
      (this.state.hovered ? " fade-out" : "");
    let cartClasses =
      "add-to-cart " +
      (this.props.isVertical
        ? "add-to-cart-vertical"
        : "add-to-cart-horizontal") +
      (this.state.hovered ? " show" : " hide");

    return (
      <Col xs="auto">
        <div className="img-container">
          <img
            onMouseEnter={this.onMouseEnterHandler.bind(this)}
            onMouseLeave={this.onMouseLeaveHandler.bind(this)}
            className={imgClasses}
            src={this.props.imgSrc}
            alt="plant"
          />
          <div
            onMouseEnter={this.onMouseEnterHandler.bind(this)}
            className={cartClasses}
          >
            {this.props.price} &euro; &bull; {"  "}
            <button
              className="btn-transparent"
              onClick={() =>
                this.props.addToCart({
                  name: this.props.plantName,
                  src: this.props.imgSrc,
                  price: this.props.price,
                  quantity: 1,
                })
              }
              onMouseEnter={this.onMouseEnterCartHandler.bind(this)}
              onMouseLeave={this.onMouseLeaveCartHandler.bind(this)}
            >
              <img
                className="cart"
                src={this.state.cartHovered ? blueCart : grayCart}
                alt="shopping cart"
              ></img>
            </button>
          </div>
          <span className="plant-name">{this.props.plantName}</span>
        </div>
      </Col>
    );
  }
}

export default Plant;
