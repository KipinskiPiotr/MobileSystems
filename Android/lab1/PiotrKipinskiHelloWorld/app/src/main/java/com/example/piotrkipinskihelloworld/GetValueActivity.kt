package com.example.piotrkipinskihelloworld

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_get_value.*
import kotlinx.android.synthetic.main.activity_menu.*

class GetValueActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_get_value)
        passed_value.setText(intent.getStringExtra("valueToBePassed"))
    }

    fun sendValueBack(view: android.view.View) {
        val intent = Intent(this, MenuActivity::class.java)
        intent.putExtra("valuePassedBack", passed_value.text.toString())
        startActivity(intent)
    }
}