import * as React from 'react';
import User from './User.jsx'
import SQLForm from './SQLForm.jsx'
import api from './api.js'
import './Styles/UserList.css'

class UserList extends React.Component {

    constructor(props) {
        super(props);
        this.state = { users: [] , sqlrequest: {request : ""}};

        this.onAddSQL = this.onAddSQL.bind(this);
    }
    //load data
    loadData() {
        api.Users().getUsers()
        .then(response => this.setState({ users: response.data }))
        .catch(err => console.log(err));
    }

    componentDidMount() {
        this.loadData();
    }
    async onAddSQL(sqlrequest) {
        if (sqlrequest) {
            api.Users().createSQL(sqlrequest).then(response => this.setState({users: response.data})).catch(err => console.log(err));
        }
    }
    render() {
        return <div>
            <SQLForm onSQLSubmit={this.onAddSQL} />
            <h2>List of data</h2>
            <div >
                {
                    this.state.users.map(function (user) {

                        return <User key={user.id} user={user} />
                    })
                }
            </div>
        </div>;
    }
}

export default UserList;