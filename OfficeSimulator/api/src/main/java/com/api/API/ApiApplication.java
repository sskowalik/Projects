package com.api.API;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.ConfigurableApplicationContext;

@SpringBootApplication

public class ApiApplication {

	public static void main(String[] args) {
		ConfigurableApplicationContext context = SpringApplication.run(ApiApplication.class, args);

		// Testowanie połączenia z bazą danych
		DatabaseTester databaseTester = context.getBean(DatabaseTester.class);
		databaseTester.testDatabaseConnection();
	}

}
