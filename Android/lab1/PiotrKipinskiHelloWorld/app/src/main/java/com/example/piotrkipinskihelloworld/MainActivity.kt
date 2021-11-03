package com.example.piotrkipinskihelloworld

import android.graphics.Color
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.view.Gravity
import android.view.View
import android.widget.LinearLayout
import android.widget.TextView
import android.widget.Toast
import kotlinx.android.synthetic.main.actions_layout.*

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.actions_layout)
    }

    fun writeToLogCat(view: android.view.View) {
        Log.i("MyApp", "Message from my app")
    }

    fun showToastMessage(view: View) {
        val toast = Toast.makeText(this, "The message from the second button", Toast.LENGTH_LONG)
        val toastLayout = toast.view as LinearLayout
        toastLayout.setBackgroundColor(Color.RED)
        val toastTextView = toastLayout.getChildAt(0) as TextView
        toastTextView.textSize = 30f
        toastTextView.gravity = Gravity.CENTER_HORIZONTAL
        toast.setGravity(Gravity.TOP, 0, 200)
        toast.show()
    }

    fun showXMLToast(view: android.view.View) {
        val toastView = layoutInflater.inflate(R.layout.custom_toast_layout, null)
        val toast = Toast.makeText(this, "", Toast.LENGTH_LONG)
        toast.view = toastView
        toast.show()
    }

    fun writeToEditText(view: android.view.View) {
        write_to_edit_text.setText(write_to_edit_text_button.text)
    }

    fun copyUserValueToEditText(view: android.view.View) {
        user_value_write_to_edit_text.setText(user_value_edit_text.text)
    }
}