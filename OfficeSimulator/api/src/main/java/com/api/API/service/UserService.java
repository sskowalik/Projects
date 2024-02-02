package com.api.API.service;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.api.API.model.user.User;
import com.api.API.model.user.UserRepository;

@Service
public class UserService {
    @Autowired
    private final UserRepository userRepository;

    public UserService(UserRepository userRepository) {
        this.userRepository = userRepository;
    }

    public List<User> getAllUsers() {
        return (List<User>) userRepository.findAll();
    }

    public Optional<User> getUserByEmail(String email) {
        return userRepository.findByEmail(email);
    }

    public Optional<User> getUserById(int user_id) {
        return userRepository.findById(user_id);
    }

    public User createUser(User user) {

        if (user.getEmail() == null || user.getEmail().isEmpty()) {
            throw new IllegalArgumentException("Email cannot be null or empty");
        }
        if (user.getPassword() == null || user.getPassword().isEmpty()) {
            throw new IllegalArgumentException("Password cannot be null or empty");
        }
        if (user.getName() == null || user.getName().isEmpty()) {
            throw new IllegalArgumentException("Name cannot be null or empty");
        }
        if (user.getSurname() == null || user.getSurname().isEmpty()) {
            throw new IllegalArgumentException("Surname cannot be null or empty");
        }
        if (user.getDate_of_birth() == null) {
            throw new IllegalArgumentException("Birth date cannot be null or empty");
        }
        if (user.getPesel() == null || user.getPesel().length() != 11) {
            throw new IllegalArgumentException("Pesel cannot be null and must have 11 char");
        }
        if (user.getBirthplace() == null || user.getBirthplace().isEmpty()) {
            throw new IllegalArgumentException("Birthplace cannot be null or empty");
        }
        if (user.getDomicile() == null || user.getDomicile().isEmpty()) {
            throw new IllegalArgumentException("Domicile cannot be null or empty");
        }

        return userRepository.save(user);
    }

    public User updateUserPassword(String email, String new_password) {
        Optional<User> existingUserOptional = userRepository.findByEmail(email);

        if (existingUserOptional.isPresent()) {
            User existingUser = existingUserOptional.get();

            // Update the password and save the user
            existingUser.setPassword(new_password.substring(1, 13));
            return userRepository.save(existingUser);
        } else {
            throw new IllegalArgumentException("User with email" + email + " not found");
        }
    }

    public void deleteUser(int user_id) {
        userRepository.deleteById(user_id);
    }

    public boolean login(String email, String password) {

        Optional<User> userOptional = userRepository.findByEmail(email);

        if (userOptional.isPresent()) {

            User user = userOptional.get();
            if (password.equals(user.getPassword())) {
                return true;
            } else {
                throw new IllegalArgumentException("Incorrect password");
            }
        } else {
            throw new IllegalArgumentException("User with email " + email + " not found");
        }
    }
}