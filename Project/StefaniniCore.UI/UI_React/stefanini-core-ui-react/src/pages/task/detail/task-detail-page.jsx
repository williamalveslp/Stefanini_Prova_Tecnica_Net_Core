import React from 'react';
import { TextField, Button } from '@material-ui/core';

/* Breadcrumb */
import Typography from '@material-ui/core/Typography';
import Breadcrumbs from '@material-ui/core/Breadcrumbs';
import Link from '@material-ui/core/Link';

class TaskDetailPage extends React.Component {

    constructor(props) {
        super(props);

        this.state = {
            form: {
                name: '',
                description: ''
            }
        };
        this.handleChange = this.handleChange.bind(this);
        this.saveForm = this.saveForm.bind(this);
    }

    componentDidMount() {

    }

    handleChange(e) {
        let form = this.state.form;
        form[e.target.name] = e.target.value;
        this.setState({ form: form });
    }

    saveForm(e) {
        const name = this.state.form.name;
        const description = this.state.form.description;

        alert(`Formulário salvo!\r\n\r\nNome: ${name}\r\nDescrição: ${description}`);
        e.preventDefault();
    }

    render() {
        return (
            <div>
                <Breadcrumbs aria-label="breadcrumb">
                    <Link color="inherit" href="/">Home</Link>
                    <Link color="inherit" href="/Funcionalidades">Funcionalidades</Link>
                    <Typography color="textPrimary">Cadastro</Typography>
                </Breadcrumbs>

                <br />
                <h3>Cadastro de Funcionalidades</h3>

                <div>
                    <form id='formTask' onSubmit={this.saveForm} autoComplete="off">
                        <TextField
                            id='txtName'
                            name='name'
                            label='Nome da Funcionalidade'
                            value={this.state.form.name}
                            onChange={this.handleChange}
                            style={{ width: 350 }} />

                        <br />
                        <br />

                        <TextField
                            id="txtDescription"
                            name='description'
                            label="Descrição"
                            multiline
                            rowsMax={4}
                            value={this.state.form.description}
                            onChange={this.handleChange}
                            style={{ width: 350 }} />

                        <br />
                        <br />

                        <div className='row'>
                            <Button variant="contained" style={{ marginRight: 10 }}>Voltar</Button>
                            <Button variant="contained" color="primary" type='submit'>Salvar</Button>
                        </div>
                    </form>
                </div>
            </div >
        )
    }
}

export default TaskDetailPage;