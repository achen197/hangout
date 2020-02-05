import React, {Component} from 'react';
import styles from './Calendar.module.scss';

class Calendar extends Component {
    render() {
        return (
            <div className={styles.CalendarContainer}>
                <h1>Calendar <span role="img" aria-label="Calendar Emoji">📅</span></h1>
            </div>
        )
    }
}

export default Calendar