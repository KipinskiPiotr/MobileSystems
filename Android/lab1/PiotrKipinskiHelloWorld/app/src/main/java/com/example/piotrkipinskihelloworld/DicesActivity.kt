package com.example.piotrkipinskihelloworld

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.ImageView
import kotlinx.android.synthetic.main.dice_layout.*
import kotlin.random.Random

class DicesActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.dice_layout)
    }

    fun rollTheDices(view: android.view.View) {
        val randomNumber1 = Random.nextInt(1, 7)
        val randomNumber2 = Random.nextInt(1, 7)
        setDiceImage(randomNumber1, first_dice)
        setDiceImage(randomNumber2, second_dice)
    }

    private fun setDiceImage(number: Int, imageView: ImageView) {
        when (number) {
            1 -> imageView.setImageResource(R.drawable.dice1)
            2 -> imageView.setImageResource(R.drawable.dice2)
            3 -> imageView.setImageResource(R.drawable.dice3)
            4 -> imageView.setImageResource(R.drawable.dice4)
            5 -> imageView.setImageResource(R.drawable.dice5)
            6 -> imageView.setImageResource(R.drawable.dice6)
        }
    }
}