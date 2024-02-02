package com.api.API.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.dao.EmptyResultDataAccessException;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import com.api.API.model.visit.*;
import com.api.API.service.VisitService;

@RestController
@RequestMapping("/visit")
public class VisitController {
    @Autowired
    VisitService visitService;

    @GetMapping("/{user_id}")
    public ResponseEntity<List<Visit>> getVisits(@PathVariable("user_id") int user_id) {
        List<Visit> visits = visitService.getVisits(user_id);
        return new ResponseEntity<>(visits, HttpStatus.OK);
    }

    @PostMapping
    public ResponseEntity<Visit> createVisit(@RequestBody Visit visit) {
        try {
            Visit createdVisit = visitService.createVisit(visit);
            return new ResponseEntity<>(createdVisit, HttpStatus.CREATED);
        } catch (IllegalArgumentException e) {
            return new ResponseEntity<>(HttpStatus.BAD_REQUEST);
        }
    }

    @DeleteMapping("/{visit_id}")
    public ResponseEntity<Void> deleteVisit(@PathVariable("visit_id") int visit_id) {
        try {
            visitService.deleteVisit(visit_id);
            return new ResponseEntity<>(HttpStatus.NO_CONTENT);
        } catch (EmptyResultDataAccessException e) {
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
    }
}