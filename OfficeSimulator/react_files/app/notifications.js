import React, {useState} from 'react';
import { View, Text, Image, ImageBackground, TouchableOpacity, Alert, TextInput } from 'react-native';
import { styles_menu } from './style-menu';
import { styles_notifications } from './style-notifications';
import { useNavigation } from '@react-navigation/native';

const Notifications = () => {

    const navigation = useNavigation();

    return (
        <View style={styles_menu.container}>
            <View style={styles_notifications.containerTopBar}>
                <Image source={require('react_files/app/images/herb_Polski.png')} style={styles_notifications.herbPolski} />
                <Text style={styles_notifications.urzedasPl}>URZĘDAS.PL</Text>
            </View>
            <View style={styles_menu.lineTop}></View>
            <View style={styles_menu.containerBodyTiles}>
                <Text style={styles_notifications.notificationHeader}>NAJNOWSZE POWIADOMIENIA O APLIKACJI!</Text>
                <View style={styles_notifications.containerNotifications}>
                    <TouchableOpacity style={[styles_notifications.notificationButton]}>
                        <Text style={[styles_notifications.notificationText]}>Już dostępna wersja 1.0!</Text>
                        <Text style={[styles_notifications.notificationText2]}>25.01.2024</Text>
                    </TouchableOpacity>
                </View>
            </View>
            <View style={styles_menu.containerBottomBar}>
                <Image source={require('react_files/app/images/COI.png')} style={styles_menu.coi} />
                <Image source={require('react_files/app/images/ministerstwo_cyfryzacji.png')} style={styles_menu.mc} />
                <Text style={styles_menu.versionText}>wersja 1.0</Text>
            </View>
        </View>
    );
};
export default Notifications;
