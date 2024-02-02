package com.api.API.model.visit;

import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.LocalTime;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "visit")

public class Visit {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)

    int visit_id;
    int user_id;
    int office_id;
    LocalDate visit_date;
    LocalTime visit_time;
    String additional_notes;
    LocalDateTime created_at;

    public Visit() {
    }

    public Visit(int visit_id, int user_id, int office_id, LocalDate visit_date, LocalTime visit_time,
            String additional_notes, LocalDateTime created_at) {
        this.visit_id = visit_id;
        this.user_id = user_id;
        this.office_id = office_id;
        this.visit_date = visit_date;
        this.visit_time = visit_time;
        this.additional_notes = additional_notes;
        this.created_at = created_at;
    }

    public int getVisit_id() {
        return visit_id;
    }

    public void setVisit_id(int visit_id) {
        this.visit_id = visit_id;
    }

    public int getUser_id() {
        return user_id;
    }

    public void setUser_id(int user_id) {
        this.user_id = user_id;
    }

    public int getOffice_id() {
        return office_id;
    }

    public void setOffice_id(int office_id) {
        this.office_id = office_id;
    }

    public LocalDate getVisit_date() {
        return visit_date;
    }

    public void setVisit_date(LocalDate visit_date) {
        this.visit_date = visit_date;
    }

    public LocalTime getVisit_time() {
        return visit_time;
    }

    public void setVisit_time(LocalTime visit_time) {
        this.visit_time = visit_time;
    }

    public String getAdditional_notes() {
        return additional_notes;
    }

    public void setAdditional_notes(String additional_notes) {
        this.additional_notes = additional_notes;
    }

    public LocalDateTime getCreated_at() {
        return created_at;
    }

    public void setCreated_at(LocalDateTime created_at) {
        this.created_at = created_at;
    }
}
