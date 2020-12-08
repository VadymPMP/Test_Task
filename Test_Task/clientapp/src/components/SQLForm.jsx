import * as React from 'react';
import './Styles/SQLForm.css'

class SQLForm extends React.Component {

    constructor(props) {
        super(props);
        this.state = { request: ""};

        this.onSubmit = this.onSubmit.bind(this);
        this.onNameChange = this.onNameChange.bind(this);
    }
    onNameChange(e) {
        this.setState({ request: e.target.value });
    }
    
    onSubmit(e) {
        e.preventDefault();
        var FirstName = this.state.request;

        if (!FirstName) {
            return;
        }
        this.props.onSQLSubmit({ request: FirstName});
        this.setState({ request: ""});
    }
    render() {
        return (
            <form onSubmit={this.onSubmit}>
                <p>
                    <input type="text"
                        placeholder="SQL request"
                        value={this.state.request}
                        onChange={this.onNameChange} />
                </p>
                <input type="submit" value="Send" />
            </form>
        );
    }
}

export default SQLForm;