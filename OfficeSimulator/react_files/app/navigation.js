import React from 'react';
import { NavigationContainer } from '@react-navigation/native';
import { createStackNavigator } from '@react-navigation/stack';
import Login from './index';
import Menu from './menu';
import PasswordRecovery from './passwordRecovery';
import Registration from './registration';
import Info from './info';
import Notifications from './notifications';
import VisitPlanner from './visitPlanner';
import Account from './account';
import Visits from './visits';
import Offices from './offices';
import Documents from './documents';
import Reservation from './reservation';


const Stack = createStackNavigator();

const Navigation = () => {
  return (
    <NavigationContainer>
      <Stack.Navigator initialRouteName="index">
        <Stack.Screen name="index" component={Login} />
        <Stack.Screen name="menu" component={Menu} />
        <Stack.Screen name="passwordRecovery" component={PasswordRecovery} />
        <Stack.Screen name="registration" component={Registration} />
        <Stack.Screen name="info" component={Info} />
        <Stack.Screen name="notifications" component={Notifications} />
        <Stack.Screen name="visitPlanner" component={VisitPlanner} />
        <Stack.Screen name="account" component={Account} />
        <Stack.Screen name="visits" component={Visits} />
        <Stack.Screen name="offices" component={Offices} />
        <Stack.Screen name="documents" component={Documents} />
        <Stack.Screen name="reservation" component={Reservation} />


      </Stack.Navigator>
    </NavigationContainer>
  );
};

export default Navigation;
