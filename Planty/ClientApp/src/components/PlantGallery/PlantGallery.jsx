import React, { Component } from "react";
import Plant from "../Plant/Plant";
import calathea from "../../Images/CalatheaOrbifolia.webp";
import monstera from "../../Images/Monstera.webp";
import hosta from "../../Images/HostaPlantaginea.webp";
import nopalea from "../../Images/NopaleaCochenillifera.webp";
import sanchezia from "../../Images/SancheziaNobilis.webp";
import codiaeum from "../../Images/CodiaeumVariegatum.webp";
import sedum from "../../Images/SedumMakinoi.webp";
import muehlenbeckia from "../../Images/MuehlenbeckiaComplexa.webp";
import "./PlantGallery.css";
import { Row, Container } from "react-bootstrap";
import { Element } from "react-scroll";
import ScrollAnimation from "react-animate-on-scroll";

class PlantGallery extends Component {
  state = {};

  render() {
    const verticalItems = plantsVertical.map((item, key) => (
      <Plant
        key={item.name}
        imgSrc={item.src}
        price={item.price}
        plantName={item.name}
        isVertical={item.isVertical}
        addToCart={this.props.addToCart}
      ></Plant>
    ));

    const horizontalItems = plantsHorizontal.map((item, key) => (
      <Plant
        key={item.name}
        imgSrc={item.src}
        price={item.price}
        plantName={item.name}
        isVertical={item.isVertical}
        addToCart={this.props.addToCart}
      ></Plant>
    ));

    return (
      <Element name="plants">
        <div className="plant-gallery">
          <ScrollAnimation
            animateIn="animate__animated animate__fadeIn"
            duration={5}
          >
            <h1 className="title">Gallery</h1>
          </ScrollAnimation>
          <Container className="gallery-container">
            <Row>{verticalItems}</Row>
            <Row>{horizontalItems}</Row>
          </Container>
        </div>
      </Element>
    );
  }
}

const plantsVertical = [
  {
    name: "Calathea Orbifolia",
    price: 999.99,
    src: calathea,
    isVertical: true,
  },
  {
    name: "Monstera",
    price: 999.99,
    src: monstera,
    isVertical: true,
  },
  {
    name: "Nopalea Cochenillifera",
    price: 999.99,
    src: nopalea,
    isVertical: true,
  },
  {
    name: "Codiaeum Variegatum",
    price: 999.99,
    src: codiaeum,
    isVertical: true,
  },
  {
    name: "Sanchezia Nobilis",
    price: 999.99,
    src: sanchezia,
    isVertical: true,
  },
  {
    name: "Sedum Makinoi",
    price: 999.99,
    src: sedum,
    isVertical: true,
  },
];

const plantsHorizontal = [
  {
    name: "Hosta Plantaginea",
    price: 999.99,
    src: hosta,
    isVertical: false,
  },
  {
    name: "Muehlenbeckia Complexa",
    price: 999.99,
    src: muehlenbeckia,
    isVertical: false,
  },
];

export default PlantGallery;
