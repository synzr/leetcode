class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        dictionary = {}
        number_count = len(nums)

        for index in range(number_count):
            current_number = nums[index]
            complement_number = target - current_number

            if complement_number in dictionary:
                return [dictionary[complement_number], index]
            
            dictionary[current_number] = index
        
        return None
