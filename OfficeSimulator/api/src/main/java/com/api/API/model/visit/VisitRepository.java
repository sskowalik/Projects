package com.api.API.model.visit;

import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;
import java.util.List;

public interface VisitRepository extends CrudRepository<Visit, Integer> {

    @Query("SELECT v FROM Visit v WHERE v.user_id = ?1")
    List<Visit> findAllByUserId(int user_id);
}
