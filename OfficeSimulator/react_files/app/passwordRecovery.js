import React, {useState} from 'react';
import { View, Text, Image, ImageBackground, TouchableOpacity, Alert, ScrollView, TextInput } from 'react-native';
import { styles_login } from './style-login';
import { styles_passRec } from './style-passRec';
import { useNavigation } from '@react-navigation/native';
import axios from './ConfigAxios.ts';
const PasswordRecovery = () => {
    const [email, setEmail] = useState('');
    const [email2, setEmail2] = useState('');

    function generateRandomPassword() {
        const characters = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789';
        let password = '';
        
        for (let i = 0; i < 12; i++) {
          const randomIndex = Math.floor(Math.random() * characters.length);
          password += characters.charAt(randomIndex);
        }
        
        return password;
      }
      let new_password = generateRandomPassword();
    const navigation = useNavigation();
    const mailApiKey = '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';
    
    const recoverPress1 = async () => {
        try {
            const response = await axios.post(
                'https://api.sendinblue.com/v3/smtp/email',
                {
                    sender: { name: 'Urzędas.pl', email: 'haslo@urzedas.pl' },
                    to: [{ email: email }],
                    subject: 'Odzyskiwanie hasła w aplikacji Urzędas.pl',
                    textContent: `Oto Twoje tymczasowe hasło w aplikacji Urzędas.pl: ${new_password}.\nMożesz je zmienić przy następnym logowaniu się do aplikacji.`,
                },
                {
                    headers: {
                        'Content-Type': 'application/json',
                        'api-key': mailApiKey,
                    },
                }
            );

            console.log('E-mail został wysłany:', response.data);
            navigation.navigate('index');
            Alert.alert('Tymczasowe hasło zostało wysłane!', 'Sprawdź swojego maila i koniecznie zmień hasło przy następnym logowaniu.');
        } catch (error) {
            console.error('Błąd podczas wysyłania e-maila:', error);

            if (error.response) {
                console.error('Status błędu:', error.response.status);
                console.error('Dane błędu:', error.response.data);
            } else if (error.request) {
                console.error('Brak odpowiedzi:', error.request);
            } else {
                console.error('Błąd:', error.message);
            }

            Alert.alert('Błąd', 'Wystąpił błąd podczas wysyłania e-maila.');
        }
    };

    const recoverPress = () => {
        if (email === email2) {

            axios.put(`/user/${email}`, `${new_password}`)
                .then(response => {console.log(response.new_password)
                    recoverPress1();
                    navigation.navigate('index', { email: email, newPassword: new_password });
                })
                .catch(error => {
                    console.error('Błąd podczas odzyskiwania hasła:', error.message);
                    Alert.alert('Błąd', 'Nie znaleziono takiego maila');
                });
        } else {
            Alert.alert('Błąd', 'Adresy e-mail nie zgadzają się.');
        }
    };

    const infoPress = () => {
        navigation.navigate('info');
    };
    
    return (
        <ScrollView>
        <View style={styles_passRec.container}>
            <View style={styles_login.containerTopBar}>
                <Image source={require('react_files/app/images/herb_Polski.png')} style={styles_login.herbPolski} />
                <Text style={styles_login.urzedasPl}>URZĘDAS.PL</Text>
                <TouchableOpacity onPress={infoPress}>
                    <Image source={require('react_files/app/images/info.png')} style={styles_login.info} />
                </TouchableOpacity>
            </View>
            <View style={styles_login.lineTop}></View>
            <View style={styles_passRec.containerPassRecWindow}>
                <Text style={styles_passRec.recHeader}>Odzyskaj hasło</Text>
                <Text style={styles_passRec.recText}>Na podany przez ciebie e-mail wysłane zostanie tymczasowe hasło, które posłuży ci do kolejnego logowania.                                  Hasło możesz następnie zmienić                  w panelu administracyjnym.</Text>
                <Text style={styles_passRec.recMailText}>E-mail</Text>
                <TextInput style={styles_passRec.recMail} placeholder="Wprowadź e-mail" keyboardType="email-address" autoCapitalize="none" placeholderTextColor="#B3B3B3" onChangeText={(text) => setEmail(text)} value={email}></TextInput>
                <Text style={styles_passRec.recMailText}>Potwierdź E-mail</Text>
                <TextInput style={styles_passRec.recMail} placeholder="Potwierdź adres e-mail" keyboardType="email-address" autoCapitalize="none" placeholderTextColor="#B3B3B3" onChangeText={(text) => setEmail2(text)} value={email2}></TextInput>
                <TouchableOpacity style={[styles_passRec.SubmitButton, (email !== '' && email==email2) ? styles_passRec.SubmitButtonPressed : null,]} onPress={recoverPress}>
                    <Text style={[styles_passRec.SubmitText, (email !== '' && email==email2) ? styles_passRec.SubmitTextPressed : null,]}>ODZYSKAJ</Text>
                </TouchableOpacity>
            </View>
            <View style={styles_login.containerBottomBar}>
                <Image source={require('react_files/app/images/COI.png')} style={styles_login.coi} />
                <Image source={require('react_files/app/images/ministerstwo_cyfryzacji.png')} style={styles_login.mc} />
                <Text style={styles_login.versionText}>wersja 1.0</Text>
            </View>
        </View>
        </ScrollView>

    );
};
export default PasswordRecovery;
