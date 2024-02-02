package com.api.API.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.api.API.model.visit.Visit;
import com.api.API.model.visit.VisitRepository;

@Service
public class VisitService {

    @Autowired
    private final VisitRepository visitRepository;

    public VisitService(VisitRepository visitRepository) {
        this.visitRepository = visitRepository;
    }

    public List<Visit> getVisits(int user_id) {
        return (List<Visit>) visitRepository.findAllByUserId(user_id);
    }

    public Visit createVisit(Visit visit) {

        if (visit.getUser_id() <= 0) {
            throw new IllegalArgumentException("User ID cannot be less than or equal to 0");
        }
        if (visit.getOffice_id() <= 0) {
            throw new IllegalArgumentException("Office ID cannot be less than or equal to 0");
        }
        if (visit.getVisit_date() == null) {
            throw new IllegalArgumentException("Visit date cannot be null");
        }
        if (visit.getVisit_time() == null) {
            throw new IllegalArgumentException("Visit time cannot be null");
        }
        if (visit.getAdditional_notes() == null || visit.getAdditional_notes().isEmpty()) {
            throw new IllegalArgumentException("Additional notes cannot be null or empty");
        }
        if (visit.getCreated_at() == null) {
            throw new IllegalArgumentException("Created at cannot be null");
        }

        return visitRepository.save(visit);
    }

    public void deleteVisit(int visit_id) {
        visitRepository.deleteById(visit_id);
    }
}
