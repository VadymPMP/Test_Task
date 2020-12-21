import * as React from 'react';
import Element from './User.jsx'
import SQLForm from './SQLForm.jsx'
import api from './api.js'


class UserList extends React.Component {

    constructor(props) {
        super(props);
        this.state = { objects: [] , sqlrequest: {request : ""}};

        this.onAddSQL = this.onAddSQL.bind(this);
    }
    //load data
    loadData() {
        api.Users().getUsers()
        .then(response => this.setState({ objects: response.data }))
        .catch(err => console.log(err));
    }

    componentDidMount() {
        this.loadData();
    }
    async onAddSQL(sqlrequest) {
        if (sqlrequest) {
            api.Users().createSQL(sqlrequest).then(response => this.setState({objects: response.data})).catch(err => console.log(err));
        }
    }
    render() {
        return <div>
            <SQLForm onSQLSubmit={this.onAddSQL} />
            <h2>List of data</h2>
            <div >
                {
                    this.state.objects.map(function (object) {
                        return <Element key={object.id} object={object} />
                    })
                }
            </div>
        </div>;
    }
}

export default UserList;