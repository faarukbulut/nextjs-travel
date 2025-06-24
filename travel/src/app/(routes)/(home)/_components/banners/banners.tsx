import Image from 'next/image'
import React from 'react'

const Banners = () => {
  return (
    <div className='mx-auto container lg:mt-8 md:mt-44 mt-64'>
        <div className='flex flex-col md:flex-row gap-8 px-3 lg:px-28'>
            <div className='group overflow-hidden relative'>
                <Image src="/home/1.jpg" width={1260} height={590} alt='' className='rounded-xl transition-transform duration-3000 group-hover:scale-110' />
            </div>
            <div className='group overflow-hidden relative'>
                <Image src="/home/2.jpg" width={1260} height={590} alt='' className='rounded-xl transition-transform duration-3000 group-hover:scale-110' />
            </div>
        </div>
    </div>
  )
}

export default Banners