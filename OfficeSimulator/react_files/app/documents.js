import React, {useState} from 'react';
import { View, Text, Image, ImageBackground, TouchableOpacity, Linking  } from 'react-native';
import { styles_menu } from './style-menu';
import { styles_documents } from './style-documents';
import { useNavigation } from '@react-navigation/native';

const Documents = () => {

    const navigation = useNavigation();

    const notificationPress = () => {
        navigation.navigate('notifications');
    };
    
    const handleLinkPress = (url) => async () => {
        await Linking.openURL(url);
    };

    return (
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
            <Text style={styles_documents.documentsHeader}>WNIOSEK O WYDANIE DOWODU OSOBISTEGO</Text>
            <TouchableOpacity style={[styles_documents.downloadButton]} onPress={handleLinkPress('https://www.gov.pl/attachment/6fd84906-d6cb-47d5-87f8-01bf7c984b3a')}>
                <Text style={[styles_documents.downloadText]}>POBIERZ WNIOSEK</Text>
            </TouchableOpacity>
            <Text style={styles_documents.documentsHeader}>WNIOSEK O PRZYZNANIE KARTY DUŻEJ RODZINY</Text>
            <TouchableOpacity style={[styles_documents.downloadButton]} onPress={handleLinkPress('https://www.gov.pl/attachment/805fc40b-75bf-412a-a840-e3377f7d22ef')}>
                <Text style={[styles_documents.downloadText]}>POBIERZ WNIOSEK</Text>
            </TouchableOpacity>
            <Text style={styles_documents.documentsHeader}>ZGŁOSZENIE POBYTU STAŁEGO</Text>
            <TouchableOpacity style={[styles_documents.downloadButton]} onPress={handleLinkPress('https://obywatel.gov.pl/documents/10181/0/Zg%C5%82oszenie+pobytu+sta%C5%82ego+2018.pdf/f0d53129-0104-4bb5-82ff-e37be3a5010b')}>
                <Text style={[styles_documents.downloadText]}>POBIERZ WNIOSEK</Text>
            </TouchableOpacity>
            <Text style={styles_documents.documentsHeader}>WNIOSEK O WYDANIE PRAWA JAZDY</Text>
            <TouchableOpacity style={[styles_documents.downloadButton]} onPress={handleLinkPress('https://www.gov.pl/attachment/d87c1645-beac-45c2-9ad0-975459b9dc2f')}>
                <Text style={[styles_documents.downloadText]}>POBIERZ WNIOSEK</Text>
            </TouchableOpacity>
            <Text style={styles_documents.documentsHeader}>REJESTRACJA/WYREJESTROWANIE POJAZDU</Text>
            <TouchableOpacity style={[styles_documents.downloadButton]} onPress={handleLinkPress('https://obywatel.gov.pl/documents/10181/0/wniosek_o_rejestracje-wyrejestrowanie_1.pdf/5593d1d8-5a17-47a8-a78a-9b4f2944b920')}>
                <Text style={[styles_documents.downloadText]}>POBIERZ WNIOSEK</Text>
            </TouchableOpacity>
            </View>
            <View style={styles_menu.containerBottomBar}>
                <Image source={require('react_files/app/images/COI.png')} style={styles_menu.coi} />
                <Image source={require('react_files/app/images/ministerstwo_cyfryzacji.png')} style={styles_menu.mc} />
                <Text style={styles_menu.versionText}>wersja 1.0</Text>
            </View>
        </View>
    );
};
export default Documents;
