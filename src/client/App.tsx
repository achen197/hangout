import React from 'react';
import Navbar from "./components/Navbar/Navbar"
import Form from "./components/Form/Form"
import './App.scss';
import Calendar from './components/Calendar/Calendar';

const App = () => {
  return (
    <div className="MainContainer">
      <header className="Header">
        <Navbar />
      </header>
      <div className="BodyContainer">
        <Form />
        <Calendar />
      </div>

    </div>
  );
}

export default App
