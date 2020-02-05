import React from "react";
import styles from "./Input.module.scss";

interface IInputProps {
  type: string
  name: string
  value: string
  placeholder?: string
  label: string
  onChange?: () => void
}

const Input = (props: IInputProps) => {
  return (
    <div className={styles.TextInput}>
      <label>
        <p>{props.label}</p>
        <input
          type={props.type}
          name={props.name}
          value={props.value}
          placeholder={props.placeholder}
          onChange={props.onChange}
        />
      </label>
    </div>
  )
}

export default Input
