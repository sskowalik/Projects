import React, { useState } from 'react';
import { View, Text, Image, TouchableOpacity, Alert, ScrollView, TextInput, StyleSheet } from 'react-native';
import { styles_login } from './style-login';
import { styles_register } from './style-register';
import { useNavigation } from '@react-navigation/native';
import DateTimePicker from '@react-native-community/datetimepicker';
import axios from './ConfigAxios.ts';
const formatDate = (date) => {
  const options = { year: 'numeric', month: 'long', day: 'numeric' };
  return date.toLocaleDateString(undefined, options);
};

const Registration = () => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [confPassword, setPassword1] = useState('');
  const [name, setName] = useState(null);
  const [second_name, setsecond_name] = useState(null);
  const [surname, setSurname] = useState(null);
  const [date_of_birth, setdate_of_birth] = useState(new Date());
  const [pesel, setPesel] = useState(null);
  const [birthplace, setBirthplace] = useState(null);
  const [domicile, setDomicile] = useState(null);
  const [mothers_name, setmothers_name] = useState(null);
  const [fathers_name, setfathers_name] = useState(null);
  const [showDatePicker, setShowDatePicker] = useState(false);

  const navigation = useNavigation();
  const registerPress = () => {
    // Sprawdź, czy hasła się zgadzają
    if (password !== confPassword) {
      Alert.alert('Błąd', 'Hasła nie są zgodne.');
      return;
    }

    // Utwórz obiekt z danymi rejestracji
    const userData = {
      email,
      password,
      name,
      second_name,
      surname,
      date_of_birth,
      pesel,
      birthplace,
      domicile,
      mothers_name,
      fathers_name,
    };

    // Wyślij żądanie POST z danymi rejestracji
    axios.post('/user',userData, {headers: {'content-type': 'application/json'}})
      .then(response => {
        console.log(response.data);
        // Obsłuż odpowiedź serwera, np. wyświetl komunikat o sukcesie
        Alert.alert('Sukces', 'Twoje konto zostało utworzone! Zaloguj się i korzystaj ze wszystkich dostępnych funkcji aplikacji.');
        navigation.navigate('index'); // Przejdź do innej ścieżki po zarejestrowaniu
      })
      .catch(error => {
        // Obsłuż błędy związane z rejestracją, np. wyświetl błąd serwera
        console.error('Błąd rejestracji:', error.message);
        Alert.alert('Błąd rejestracji', 'Wystąpił błąd podczas rejestracji. Spróbuj ponownie później.');
      });
  };
  
  const isValidEmail = (email) => {
    // Use a regular expression to validate the email format
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return emailRegex.test(email);
  };
  
  const infoPress = () => {
    navigation.navigate('info');
  };

  return (
    <ScrollView>
      <View style={styles_register.container}>
        <View style={styles_login.containerTopBar}>
          <Image source={require('react_files/app/images/herb_Polski.png')} style={styles_login.herbPolski} />
          <Text style={styles_login.urzedasPl}>URZĘDAS.PL</Text>
          <TouchableOpacity onPress={infoPress}>
            <Image source={require('react_files/app/images/info.png')} style={styles_login.info} />
          </TouchableOpacity>
        </View>
        <View style={styles_login.lineTop}></View>
        <View style={styles_register.containerPassRegWindow}>
          <Text style={styles_register.regHeader}>Dołącz do serwisu! Ułatw sobie załatwienie urzędowych spraw!</Text>
          <Text style={styles_register.regText}>Wypełnij formularz i uzyskaj dostęp do rezerwacji terminów. Pamiętaj, żeby podawać prawidłowe dane - będą one weryfikowane przy każdej wizycie w urzędzie! </Text>
          <Text style={styles_register.regFormText}>E-mail</Text>
          <TextInput style={styles_register.regForm} placeholder="..." keyboardType="email-address" autoCapitalize="none" placeholderTextColor="#B3B3B3" onChangeText={(text) => setEmail(text)} value={email}></TextInput>
          <Text style={styles_register.regFormText}>Hasło</Text>
          <TextInput style={styles_register.regForm} placeholder="..." placeholderTextColor="#B3B3B3" secureTextEntry onChangeText={(text) => setPassword(text)} value={password}></TextInput>
          <Text style={styles_register.regFormText}>Potwierdź hasło</Text>
          <TextInput style={styles_register.regForm} placeholder="..." placeholderTextColor="#B3B3B3" secureTextEntry onChangeText={(text) => setPassword1(text)} value={confPassword}></TextInput>
          <Text style={styles_register.regFormText}>Imię</Text>
          <TextInput style={styles_register.regForm} placeholder="..." autoCapitalize="none" placeholderTextColor="#B3B3B3" onChangeText={(text) => setName(text)} value={name}></TextInput>
          <Text style={styles_register.regFormText}>Drugie imię</Text>
          <TextInput style={styles_register.regForm} placeholder="..." autoCapitalize="none" placeholderTextColor="#B3B3B3" onChangeText={(text) => setsecond_name(text)} value={second_name}></TextInput>
          <Text style={styles_register.regFormText}>Nazwisko</Text>
          <TextInput style={styles_register.regForm} placeholder="..." autoCapitalize="none" placeholderTextColor="#B3B3B3" onChangeText={(text) => setSurname(text)} value={surname}></TextInput>
          <Text style={styles_register.regFormText}>Data urodzenia</Text>
          <TouchableOpacity style={styles_register.regForm} onPress={() => setShowDatePicker(true)}>
            <Text style={styles_register.dateText}>{date_of_birth ? formatDate(date_of_birth) : 'Wybierz datę'}</Text>
          </TouchableOpacity>
          {showDatePicker && (
            <DateTimePicker
              mode="date"
              value={date_of_birth}
              onChange={(event, selectedDate) => {
                setShowDatePicker(false);
                const currentDate = selectedDate || date_of_birth;
                setdate_of_birth(currentDate);
              }}
              onTouchCancel={() => setShowDatePicker(false)}
              onTouchEnd={() => setShowDatePicker(true)}
            />
          )}
          <Text style={styles_register.regFormText}>PESEL</Text>
          <TextInput
  style={styles_register.regForm}
  placeholder="..."
  keyboardType="numeric"
  autoCapitalize="none"
  placeholderTextColor="#B3B3B3"
  onChangeText={(text) => {
    // Sprawdzenie, czy wprowadzone znaki są cyframi
    const numericValue = text.replace(/[^0-9]/g, ''); // Pozostawia tylko cyfry

    // Ograniczenie do 11 znaków
    const limitedValue = numericValue.substring(0, 11);

    setPesel(limitedValue);
  }}
  value={pesel}
>
</TextInput>
          <Text style={styles_register.regFormText}>Miejsce urodzenia</Text>
          <TextInput style={styles_register.regForm} placeholder="..." autoCapitalize="none" placeholderTextColor="#B3B3B3" onChangeText={(text) => setBirthplace(text)} value={birthplace}></TextInput>
          <Text style={styles_register.regFormText}>Miejsce zameldowania</Text>
          <TextInput style={styles_register.regForm} placeholder="..." autoCapitalize="none" placeholderTextColor="#B3B3B3" onChangeText={(text) => setDomicile(text)} value={domicile}></TextInput>
          <Text style={styles_register.regFormText}>Imię matki</Text>
          <TextInput style={styles_register.regForm} placeholder="..." autoCapitalize="none" placeholderTextColor="#B3B3B3" onChangeText={(text) => setmothers_name(text)} value={mothers_name}></TextInput>
          <Text style={styles_register.regFormText}>Imię ojca</Text>
          <TextInput style={styles_register.regForm} placeholder="..." autoCapitalize="none" placeholderTextColor="#B3B3B3" onChangeText={(text) => setfathers_name(text)} value={fathers_name}></TextInput>
          <TouchableOpacity style={[styles_register.SubmitButton, (isValidEmail(email) !== '' && password !== '' && password===confPassword) ? styles_register.SubmitButtonPressed : null,]} onPress={registerPress}>
                    <Text style={[styles_register.SubmitText, (isValidEmail(email) !== '' && password !== '' && password===confPassword) ? styles_register.SubmitTextPressed : null,]}>DOŁĄCZ DO NAS!</Text>
          </TouchableOpacity>
        </View>
        <View style={styles_login.containerBottomBar}>
          <Image source={require('react_files/app/images/COI.png')} style={styles_login.coi} />
          <Image source={require('react_files/app/images/ministerstwo_cyfryzacji.png')} style={styles_login.mc} />
          <Text style={styles_login.versionText}>wersja 0.1</Text>
        </View>
      </View>
    </ScrollView>
  );
};

export default Registration;
