package com.api.API.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import java.util.Optional;

import com.api.API.model.office.*;
import com.api.API.service.OfficeService;

@RestController
@RequestMapping("/office")
public class OfficeController {
    @Autowired
    OfficeService officeService;

    @GetMapping
    public ResponseEntity<List<Office>> getAllOffices() {
        return new ResponseEntity<>(officeService.getAllOffices(), HttpStatus.OK);
    }

    @GetMapping("/{office_id}")
    public ResponseEntity<Office> getUserById(@PathVariable("office_id") int office_id) {
        Optional<Office> office = officeService.getUserById(office_id);
        if (office != null) {
            return new ResponseEntity<>(office.get(), HttpStatus.OK);
        } else {
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
    }

}