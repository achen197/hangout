import React from "react";
import styles from "./Form.module.scss";
import FormComponent from "./FormComponent";

const Form = () => {
    return (
      <div className={styles.FormContainer}>
        <h1>Hey there <span role="img" aria-label="wave">👋</span> Trying to organise a hangout with mates?</h1>
        <h2>Let's grab a few details first</h2>

        <div className={styles.HowContainer}>
          <p>How it works:</p>
          <ol>
            <li>Fill out the details below</li>
            <li>Generate a link to send to your mates you want to hang with</li>
            <li>
              They fill out the dates they're free and you'll be able to see
              what days suits everyone on the calendar <span role="img" aria-label="point">👉</span>
            </li>
          </ol>
        </div>
        <FormComponent />
      </div>
    )
}

export default Form;
