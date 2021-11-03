package com.example.piotrkipinskihelloworld

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle

class MenuActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_menu)
    }

    fun runTestActionsActivity(view: android.view.View) {
        val intent = Intent(this, MainActivity::class.java)
        startActivity(intent)
    }

    fun runHowManyFingersActivity(view: android.view.View) {
        val intent = Intent(this, HowManyFingersActivity::class.java)
        startActivity(intent)
    }
}