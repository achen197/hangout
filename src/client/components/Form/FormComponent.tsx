import React, { Component } from "react";
import Input from "../Form/Input/Input";
import Button from "../Button";

interface IFormProps {
  name: string;
  event: string;
  dates: string;
}

const FormComponent = (props: IFormProps) => {
  // constructor(props: any) {
  //   super(props);
  //   this.state = {
  //     name: "",
  //     event: "",
  //     dates: ""
  //   };
  // }

  // render() {
  //   return (
  //     <form>
  //       <Input
  //         type="text"
  //         label="What's your name?"
  //         name="name"
  //         value={this.state.name}
  //       />

  //       <Input
  //         type="text"
  //         label="What event are you planning?"
  //         placeholder="eg. brunch, drinks, birthday"
  //         name="event"
  //         value={this.state.event}
  //       />

  //       <Input
  //         type="text"
  //         label="What days are you available?"
  //         placeholder="dd/mm/yyyy"
  //         name="dates"
  //         value={this.state.dates}
  //       />
  //       <Button text="Generate Link" />
  //     </form>
  //   );
  // }
}

export default FormComponent;
