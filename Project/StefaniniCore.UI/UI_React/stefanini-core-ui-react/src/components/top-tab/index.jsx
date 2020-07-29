import React from 'react';
import '../../components/top-tab/top-tab.css';

//import { BrowserRouter as Router, Link, Route, Switch } from 'react-router-dom';

/* Router */
import { BrowserRouter, Link } from 'react-browser-router';

/* Tab */
import PropTypes from 'prop-types';
import { makeStyles } from '@material-ui/core/styles';
import AppBar from '@material-ui/core/AppBar';
import Tabs from '@material-ui/core/Tabs';
import Tab from '@material-ui/core/Tab';
import Typography from '@material-ui/core/Typography';
import Box from '@material-ui/core/Box';

import Home from '../../pages/home';
import TaskDetailPage from '../../pages/task/detail/task-detail-page.jsx';
import TaskListPage from  '../../pages/task/list/task-list-page.jsx';

export function TabPanel(props) {
    const { children, value, index, ...other } = props;

    return (
        <div
            role="tabpanel"
            hidden={value !== index}
            id={`wrapped-tabpanel-${index}`}
            aria-labelledby={`wrapped-tab-${index}`}
            {...other}>

            {value === index && (
                <Box p={3}>
                    <Typography>{children}</Typography>
                </Box>
            )}
        </div>
    );
}

TabPanel.propTypes = {
    children: PropTypes.node,
    index: PropTypes.any.isRequired,
    value: PropTypes.any.isRequired,
};

const useStyles = makeStyles((theme) => ({
    root: {
        flexGrow: 1,
        backgroundColor: theme.palette.background.paper,
    },
}));

export default function TabsWrappedLabel() {
    const classes = useStyles();
    const [value, setValue] = React.useState('taskList');

    const handleChange = (event, newValue) => {
        setValue(newValue);
    };

    return (
        <BrowserRouter>

            <div className={classes.root}>
                <AppBar position="static">
                    <Tabs value={value} onChange={handleChange} aria-label="wrapped label tabs example">

                        <Tab
                            value="taskList"
                            label="Listar Funcionalidades"
                            component={Link} exact='true' to='/Funcionalidades/' />

                        <Tab
                            value="taskDetail"
                            label="Cadastrar Funcionalidades"
                            component={Link} exact='true' to='/Funcionalidades/Cadastro/' />

                        <Tab value="profiles"
                            label="Perfis"
                            component={Link} exact='true' to='/Perfis/' />

                        <Tab value="user-systems" label="Usuários"
                            component={Link} exact='true' to='/Usuários/' />
                    </Tabs>
                </AppBar>

                <TabPanel value={value} index="home" className='sizePanel'>
                    <Home />
                </TabPanel>

                <TabPanel value={value} index="taskList" className='sizePanel'>
                    <TaskListPage />
                </TabPanel>

                <TabPanel value={value} index="taskDetail" className='sizePanel'>
                    <TaskDetailPage />
                </TabPanel>

                <TabPanel value={value} index="profiles" className='sizePanel'>
                    Item Two
                </TabPanel>
                <TabPanel value={value} index="user-systems" className='sizePanel'>
                    Item Three
                </TabPanel>
            </div>

        </BrowserRouter>
    );
}