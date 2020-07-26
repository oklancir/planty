import React, { Component } from "react";
import "./App.css";
import MNavbar from "./components/Navbar/Navbar";
import Home from "./components/Home/Home";
import Footer from "./components/Footer/Footer";
import PlantGallery from "./components/PlantGallery/PlantGallery";
import Cart from "./components/Cart/Cart";
import Contact from "./components/Contact/Contact";
import Login from "./components/Login/Login";

class App extends Component {
  constructor(props) {
    super(props);

    this.state = {
      items: [],
      isCartEmpty: true,
      isLogedIn: false,
      loading: false,
    };
  }

  login(username, pass) {
    this.setState({
      loading: true,
    });
    if (username === "saracuzele@gmail.com" && pass === "sara") {
      this.setState({
        isLogedIn: true,
        loading: false,
      });
    } else {
    }
  }

  addToCart(item) {
    let { items } = this.state;
    let cartItem = items.find((el) => el.name === item.name);
    if (cartItem) {
      cartItem.quantity += 1;
    } else {
      items.push(item);
    }
    const isCartEmpty = items.length ? false : true;
    this.setState({
      items: items,
      isCartEmpty: isCartEmpty,
    });
  }

  removeFromCart(name, removeAll) {
    let { items } = this.state;
    let cartItem = items.find((el) => el.name === name);
    if (cartItem) {
      if (removeAll) {
        var index = items.indexOf(cartItem);
        items.splice(index, 1);
      } else {
        if (cartItem.quantity > 0) {
          cartItem.quantity -= 1;
        }
      }
    }
    const isCartEmpty = items.length ? false : true;
    this.setState({
      items: items,
      isCartEmpty: isCartEmpty,
    });
  }

  render() {
    document.body.style = this.state.isLogedIn
      ? "background: #FFDCF9;"
      : "background: #fbffb0;";

    const appBody = this.state.isLogedIn ? (
      <React.Fragment>
        {" "}
        <Home />
        <PlantGallery addToCart={this.addToCart.bind(this)} />
        <Contact />
        <Cart
          items={this.state.items}
          isCartEmpty={this.state.isCartEmpty}
          addToCart={this.addToCart.bind(this)}
          removeFromCart={this.removeFromCart.bind(this)}
        />
        <Footer />
      </React.Fragment>
    ) : (
      <Login login={this.login.bind(this)} />
    );
    return (
      <div className="App">
        <MNavbar isCartEmpty={this.state.isCartEmpty} />
        {appBody}
      </div>
    );
  }
}

export default App;
