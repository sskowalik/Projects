package com.api.API;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.stereotype.Component;

@Component
public class DatabaseTester {

    @Autowired
    private JdbcTemplate jdbcTemplate;

    public void testDatabaseConnection() {
        try {
            jdbcTemplate.execute("SELECT 1"); // Prosty test zapytania do bazy danych
            System.out.println("Połączono z bazą danych!");
        } catch (Exception e) {
            System.err.println("Błąd podczas łączenia z bazą danych: " + e.getMessage());
        }
    }
}
