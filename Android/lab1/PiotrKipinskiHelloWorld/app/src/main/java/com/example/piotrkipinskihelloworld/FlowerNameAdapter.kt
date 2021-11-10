package com.example.piotrkipinskihelloworld

import android.content.Context
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.BaseAdapter
import android.widget.ImageView
import android.widget.TextView
import kotlinx.android.synthetic.main.flower_list_item.view.flower_name
import kotlinx.android.synthetic.main.flower_list_item_1.view.*

class FlowerNameAdapter(
    private var context: Context,
    private var flowerNames: ArrayList<String>,
    private var flowerImages: ArrayList<Int>
) : BaseAdapter() {


    override fun getCount(): Int {
        return flowerNames.size
    }

    override fun getItem(p0: Int): Any {
        return flowerNames[p0]
    }

    override fun getItemId(p0: Int): Long {
        return p0.toLong()
    }

    override fun getView(p0: Int, p1: View?, p2: ViewGroup?): View {
        val layoutInflater =
            context.getSystemService(Context.LAYOUT_INFLATER_SERVICE) as LayoutInflater
        val itemView = layoutInflater.inflate(R.layout.flower_list_item_1, null, true)
        val flowerNameTextView = itemView.flower_name as TextView
        val flowerImageView = itemView.flower_image as ImageView
        flowerNameTextView.text = getItem(p0).toString()
        if (p0 % 2 == 0) {
            flowerNameTextView.setBackgroundResource(android.R.color.holo_green_dark)
        }
        flowerNameTextView.text = getItem(p0).toString()
        flowerImageView.setImageResource(flowerImages[p0])
        return itemView
    }

}