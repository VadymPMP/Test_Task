import * as React from 'react';
import './Styles/User.css'

class Element extends React.Component {

    constructor(props) {
        super(props);
        this.state = { data: props.object };
        this.keys = Object.keys(this.state.data);
    }

    render() {
        return(
            <div>
                <hr/>
                {
                    this.keys.map(k => (<p><b>{k} - {this.state.data[k]}</b></p>))                    
                }      
            </div>)
    }
}

export default Element;