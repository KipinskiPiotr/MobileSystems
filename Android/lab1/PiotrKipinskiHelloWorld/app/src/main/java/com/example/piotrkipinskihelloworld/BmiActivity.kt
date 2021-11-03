package com.example.piotrkipinskihelloworld

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.ImageView
import android.widget.Toast
import kotlinx.android.synthetic.main.activity_how_many_fingers.*
import kotlinx.android.synthetic.main.bmi_layout.*
import kotlinx.android.synthetic.main.dice_layout.*
import kotlin.random.Random

class BmiActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.bmi_layout)
    }

    fun calculateBmi(view: android.view.View) {
        if (weight_edit_text.text.isEmpty() or height_edit_text.text.isEmpty()) {
            Toast.makeText(
                this,
                "You have to type proper measures to calculate!",
                Toast.LENGTH_LONG
            ).show()
            return
        }
        val weight = weight_edit_text.text.toString().toInt()
        val height = height_edit_text.text.toString().toInt()/100.0
        val bmi = weight / height / height
        val bmiCategory = when {
            bmi < 18.5 -> BmiCategory.UNDERWEIGHT
            bmi < 25 -> BmiCategory.HEALTHY
            bmi < 30 -> BmiCategory.OVERWEIGHT
            else -> BmiCategory.OBESITY
        }
        bmi_image_view.setImageResource(bmiCategory.resourceId)
    }
}