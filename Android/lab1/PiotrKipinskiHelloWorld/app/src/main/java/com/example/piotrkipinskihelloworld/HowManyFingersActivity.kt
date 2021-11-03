package com.example.piotrkipinskihelloworld

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Toast
import kotlinx.android.synthetic.main.activity_how_many_fingers.*
import kotlin.random.Random

class HowManyFingersActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_how_many_fingers)
    }

    fun playTheGame(view: android.view.View) {
        if(number_edit_text.text.isEmpty()){
            Toast.makeText(this, "You have to pick a number first!", Toast.LENGTH_LONG).show()
            return
        }
        val randomNumber = Random.nextInt(1, 11)
        val userNumber = number_edit_text.text.toString().toInt()
        if (randomNumber == userNumber) {
            result_text_view.text = "Congratulations! You guessed right!"
        } else {
            result_text_view.text = "Unlucky! I've picked $randomNumber"
        }
    }
}