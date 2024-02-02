import React, {useState} from 'react';
import { View, Text, Image, ImageBackground, TouchableOpacity, Alert, TextInput } from 'react-native';
import { styles_info } from './style-info';
import { styles_login } from './style-login';
import { useNavigation } from '@react-navigation/native';

const Info = () => {

    const navigation = useNavigation();

    return (
        <View style={styles_info.container}>
            <View style={styles_info.containerTopBar}>
                <Image source={require('react_files/app/images/herb_Polski.png')} style={styles_info.herbPolski} />
                <Text style={styles_info.urzedasPl}>URZĘDAS.PL</Text>
            </View>
            <View style={styles_info.lineTop}></View>
            <View style={styles_info.containerMid}>
                <Text style={styles_info.Header}>Uzyskaj pomoc!</Text>
                <Text style={styles_info.Text}>Skontaktuj się z nami! </Text>
                <Text style={styles_info.Text}>Zapoznaj się z naszą polityką prywatności! </Text>
                <Text style={styles_info.Text}>Projekt współtworzony przez: </Text>
                <Text style={styles_info.TextName}>Wiktoria Janicka</Text>
                <Text style={styles_info.TextName}>Sebastian Kowalik</Text>
                <Text style={styles_info.TextName}>Miłosz Gronowski</Text>
            </View>
            <View style={styles_login.containerBottomBar}>
                <Image source={require('react_files/app/images/COI.png')} style={styles_login.coi} />
                <Image source={require('react_files/app/images/ministerstwo_cyfryzacji.png')} style={styles_login.mc} />
                <Text style={styles_login.versionText}>wersja 1.0</Text>
            </View>
        </View>
    );
};
export default Info;
