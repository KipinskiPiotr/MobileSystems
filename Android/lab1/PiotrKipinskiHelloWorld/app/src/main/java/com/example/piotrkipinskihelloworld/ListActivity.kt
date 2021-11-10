package com.example.piotrkipinskihelloworld

import android.app.Dialog
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.BaseAdapter
import kotlinx.android.synthetic.main.activity_list.*
import kotlinx.android.synthetic.main.input_box_layout.*

class ListActivity : AppCompatActivity() {
    private val listOfFlowers = ArrayList<String>()
    private val listOfFlowerImageIDs = ArrayList<Int>()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_list)

        initializeFlowerList()

//        val adapter =
//            ArrayAdapter(this, android.R.layout.simple_expandable_list_item_1, listOfFlowers)
//        flower_list.adapter = adapter

        val flowerNameAdapter = FlowerNameAdapter(this, listOfFlowers, listOfFlowerImageIDs)
        flower_list.adapter = flowerNameAdapter
        flower_list.setOnItemClickListener { parent, view, position, id ->
            showFlowerNameInputBox(
                listOfFlowers[position],
                position,
                flowerNameAdapter
            )
        }
    }

    private fun showFlowerNameInputBox(
        oldName: String,
        position: Int,
        flowerNameAdapter: FlowerNameAdapter
    ) {
        val dialog = Dialog(this)
        dialog.setTitle("Modify flower name")
        dialog.setContentView(R.layout.input_box_layout)
        dialog.input_text.setText(oldName)
        dialog.btn_update.setOnClickListener {
            listOfFlowers[position] = dialog.input_text.text.toString()
            (flowerNameAdapter as BaseAdapter).notifyDataSetChanged()
            dialog.dismiss()
        }
        dialog.show()
    }

    private fun initializeFlowerList() {
        listOfFlowers.add("Roza")
        listOfFlowers.add("Frezja")
        listOfFlowers.add("Bratek")
        listOfFlowers.add("Stokrotka")
        listOfFlowers.add("Przebisnieg")
        listOfFlowers.add("Krokus")
        listOfFlowers.add("Gozdzik")
        listOfFlowers.add("Tulipan")
        listOfFlowers.add("Aster")
        listOfFlowers.add("Chaber")
        listOfFlowers.add("Krokus")
        listOfFlowers.add("Gozdzik")
        listOfFlowers.add("Tulipan")
        listOfFlowers.add("Aster")
        listOfFlowers.add("Chaber")

        listOfFlowerImageIDs.add(R.drawable.roza)
        listOfFlowerImageIDs.add(R.drawable.frezja)
        listOfFlowerImageIDs.add(R.drawable.bratek)
        listOfFlowerImageIDs.add(R.drawable.roza)
        listOfFlowerImageIDs.add(R.drawable.frezja)
        listOfFlowerImageIDs.add(R.drawable.bratek)
        listOfFlowerImageIDs.add(R.drawable.roza)
        listOfFlowerImageIDs.add(R.drawable.frezja)
        listOfFlowerImageIDs.add(R.drawable.bratek)
        listOfFlowerImageIDs.add(R.drawable.roza)
        listOfFlowerImageIDs.add(R.drawable.frezja)
        listOfFlowerImageIDs.add(R.drawable.bratek)
        listOfFlowerImageIDs.add(R.drawable.roza)
        listOfFlowerImageIDs.add(R.drawable.frezja)
        listOfFlowerImageIDs.add(R.drawable.bratek)
    }
}