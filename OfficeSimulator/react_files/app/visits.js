import React, { useState, useEffect } from 'react';
import { View, Text, Image, TouchableOpacity, Alert } from 'react-native';
import { styles_menu } from './style-menu';
import { useNavigation, useRoute } from '@react-navigation/native';
import axios from './ConfigAxios.ts';
import { ScrollView } from 'react-native-gesture-handler';
import { styles_accounts } from './style-account';
const Visits = () => {
    const route = useRoute();
    const { userData } = route.params;
    const [dataAcc, setdataAcc] = useState(null); // Stan przechowujący dane użytkownika
    const [visits, setVisits] = useState(null);

    useEffect(() => {
        setdataAcc(parseInt(userData?.data?.user_id)); // Konwersja na liczbę i ustawienie stanu
    }, [userData]);

    useEffect(() => {
        if (dataAcc !== null) {
            printVisits(); // Pobierz dane użytkownika po montażu komponentu
        }
    }, [dataAcc]);
   
    const printVisits = async () => {
        try {
            const response = await axios.get(`/visit/${dataAcc}`);
            setVisits(response.data); 
        } catch (error) {
            console.error('Error fetching user data:', error.message);
        }
    };

    const navigation = useNavigation();

    const notificationPress = () => {
        navigation.navigate('notifications');
    };
    
    return (
        <ScrollView>
        <View style={styles_menu.container}>
            <View style={styles_menu.containerTopBar}>
                <Image source={require('react_files/app/images/herb_Polski.png')} style={styles_menu.herbPolski} />
                <Text style={styles_menu.urzedasPl}>URZĘDAS.PL</Text>
                <TouchableOpacity onPress={notificationPress}>
                    <Image source={require('react_files/app/images/notificationBell.png')} style={styles_menu.notificationBell} />
                </TouchableOpacity>
            </View>
            <View style={styles_menu.lineTop}></View>
            <View style={styles_menu.containerBodyTiles}>
    {visits && visits.map((visit, index) => (
        <View key={index} style={styles_accounts.visitContainer} >
            <Text style={styles_accounts.text2}>ID użytkownika: <Text style={styles_accounts.text3}>{visit.user_id}</Text></Text>
            <Text style={styles_accounts.text2}>ID urzędu: <Text style={styles_accounts.text3}>{visit.office_id}</Text></Text>
            <Text style={styles_accounts.text2}>Data wizyty: <Text style={styles_accounts.text3}>{visit.visit_date}</Text></Text>
            <Text style={styles_accounts.text2}>Czas wizyty: <Text style={styles_accounts.text3}>{visit.visit_time}</Text></Text>
            <Text style={styles_accounts.text2}>Dodatkowe uwagi: <Text style={styles_accounts.text3}>{visit.additional_notes}</Text></Text>
            <Text style={styles_accounts.text2}>Data utworzenia:  <Text style={styles_accounts.text3}>{visit.created_at}</Text></Text>
        </View>
    ))}
    {visits && visits.length === 0 && (
        <Text>No visits found</Text>
    )}
</View>

            <View style={styles_menu.containerBottomBar}>
                <Image source={require('react_files/app/images/COI.png')} style={styles_menu.coi} />
                <Image source={require('react_files/app/images/ministerstwo_cyfryzacji.png')} style={styles_menu.mc} />
                <Text style={styles_menu.versionText}>wersja 1.0</Text>
            </View>
        </View>
        </ScrollView>
    );
};

export default Visits;
