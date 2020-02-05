import React from "react";
import logo from "../../static/images/logo.svg";
import styles from "./Navbar.module.scss";

const Navbar = () => {
  return (
    <div className={styles.NavigationContainer}>
      <img src={logo} alt="" />
    </div>
  )
}

export default Navbar;
