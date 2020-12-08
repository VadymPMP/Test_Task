import * as React from 'react';


class User extends React.Component {

    constructor(props) {
        super(props);
        this.state = { data: props.user };
    }
    render() {
        return <div>
            <p><b>Id - {this.state.data.id}</b></p>
            <p><b>Name - {this.state.data.name}</b></p>
            <p><b>Age -  {this.state.data.age}</b></p>
        </div>;
    }
}

export default User;