import React, { Component } from "react";
import plantsImg from "../../Images/Plants.svg";
import "./Home.css";
import { Container, Row } from "react-bootstrap";
import { Element } from "react-scroll";

class Home extends Component {
  state = {};
  render() {
    return (
      <Element name="home">
        {" "}
        <Container className="home-container">
          <div className="home-page">
            {" "}
            <Row>
              <div className="col-12 col-lg-6">
                <img
                  className="home-picture"
                  src={plantsImg}
                  alt="potted plants"
                ></img>
              </div>
              <div className="col-12 col-lg-6">
                <h1 className="home-title">Planty</h1>
                <p className="home-paragraph">Order Plants from Heaven.</p>
              </div>
            </Row>
          </div>
        </Container>
      </Element>
    );
  }
}

export default Home;
