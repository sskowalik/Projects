package com.api.API.service;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.api.API.model.office.Office;
import com.api.API.model.office.OfficeRepository;

@Service
public class OfficeService {
    @Autowired
    private final OfficeRepository officeRepository;

    public OfficeService(OfficeRepository officeRepository) {
        this.officeRepository = officeRepository;
    }

    public List<Office> getAllOffices() {
        return (List<Office>) officeRepository.findAll();
    }

    public Optional<Office> getUserById(int office_id) {
        return officeRepository.findById(office_id);
    }

}